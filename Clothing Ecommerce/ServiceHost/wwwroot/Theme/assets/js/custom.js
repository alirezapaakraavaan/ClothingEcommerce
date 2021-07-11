const cookieName = "cart-items";

function addToCart(id, name, picture) {
    debugger;
    const price = $("#discountedOriginalPrice").text();
    const priceWithDiscount = $("#discountedPrice").text();
    const color = $("#productColor").val();
    const size = $("#productSize").val();

    let products = $.cookie(cookieName);
    if (products === undefined) {
        products = [];
    } else {
        products = JSON.parse(products);
    }

    const count = $("#productCount").val();
    const totalPrice = parseInt(price) * parseInt(count) * 1000;
    const unitProductPrice = parseInt(price) * 1000;
    const currentProduct = products.find(x => x.id === id);
    const subTotal = count * totalPrice;
    if (currentProduct !== undefined) {
        products.find(x => x.id === id).count = parseInt(currentProduct.count) + parseInt(count);
    } else {

        const product = {
            id,
            name,
            priceWithDiscount,
            doublePrice: price,
            unitProductPrice,
            totalPrice,
            size,
            color,
            picture,
            count,
            subTotal
        }

        products.push(product);
    }

    $.cookie(cookieName, JSON.stringify(products), { expires: 2, path: "/" });
    updateCart();
}

function updateCart() {
    let products = $.cookie(cookieName);
    products = JSON.parse(products);
    $("#cart_items_count").text(products.length);
    const cartItemsWrapper = $("#cart_items_wrapper");
    cartItemsWrapper.html("");
    products.forEach(x => {
        const product =
            `<div class="offcanvas-cart-content-container">
            <div class="cart-product-wrapper">
                <div class="cart-product-container ps-scroll" id="cart_items_wrapper">
                    <div class="single-cart-product">
                        <span class="cart-close-icon">
                            <a href="#"><i class="ti-close" onclick="removeFromCart('${x.id}')"></i></a>
                        </span>
                        <div class="image">
                            <a href="shop-product-basic.html">
                                <img src="/Theme/assets/img/products/${x.picture}" class="img-fluid" alt="">
                            </a>
                        </div>
                        <div class="content">
                            <h5><a href="shop-product-basic.html">${x.name}</a></h5>
                            <p><span class="cart-count">${x.count} x </span> <span class="discounted-price">${x
                .doublePrice}</span></p>
                        </div>
                    </div>
                </div>
            </div>
        </div>`;

        cartItemsWrapper.append(product);
    });
}

function removeFromCart(id) {
    let products = $.cookie(cookieName);
    products = JSON.parse(products);
    let itemToRemove = products.findIndex(x => x.id === id);
    products.splice(itemToRemove, 1);
    $.cookie(cookieName, JSON.stringify(products), { expires: 2, path: "/" });
    updateCart();
}

function changeCartItemCount(id, totalId, count) {
    debugger;
    var products = $.cookie(cookieName);
    products = JSON.parse(products);
    const productIndex = products.findIndex(x => x.id == id);
    const size = $("#itemSize").text();
    products[productIndex].count = count;
    const product = products[productIndex];
    const newPrice = parseInt(product.unitProductPrice) * parseInt(count);
    $(`#${totalId}`).text(newPrice);
    $.cookie(cookieName, JSON.stringify(products), { expires: 2, path: "/" });
    updateCart();

    const settings = {
        "url": "https://localhost:5001/api/Inventory",
        "method": "POST",
        "timeout": 0,
        "headers": {
            "Content-Type": "application/json"
        },
        "data": JSON.stringify({
            "productId": id,
            "size": size,
            "count": count
        })
    };

    $.ajax(settings).done(function (data) {
        if (data.isStock == false) {
            const warningsDiv = $('#productStockWarnings');
            if ($(`#${id}`).length == 0) {
                warningsDiv.append(`
                    <div class="alert alert-warning" id="${id}">
                        <i class="fa fa-warning"></i> کالای
                        <strong>${data.productName}</strong>
                        در سایز مورد نظر در انبار کمتر از تعداد درخواستی موجود است
                    </div>
                `);
            }
        } else {
            if ($(`#${id}`).length > 0) {
                $(`#${id}`).remove();
            }
        }
    });
}