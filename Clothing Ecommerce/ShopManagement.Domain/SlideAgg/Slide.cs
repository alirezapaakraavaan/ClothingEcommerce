using _0_Framework.Domain;

namespace ShopManagement.Domain.SlideAgg
{
    public class Slide : EntityBase
    {
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Hashtag { get; private set; }
        public string Title { get; private set; }
        public string BtnText { get; private set; }
        public bool IsRemoved { get; private set; }

        public Slide(string picture, string pictureAlt, string pictureTitle, string hashtag, string title,
            string btnText)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Hashtag = hashtag;
            Title = title;
            BtnText = btnText;
            IsRemoved = false;
        }

        public void Edit(string picture, string pictureAlt, string pictureTitle, string hashtag, string title,
            string btnText)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Hashtag = hashtag;
            Title = title;
            BtnText = btnText;
        }

        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
    }
}