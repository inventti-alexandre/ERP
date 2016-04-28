using System;

namespace DomainLayer.DB_Model.File
{
    public enum ContentType
    {
        JPG = 0,
        PNG=1,
        GIF=2,
        TIF=3,
        BMP=4
    }

    public enum RefrenceType
    {
        PersonnalPic=0,
    }


    public class File
    {
        public File()
        {
            Id = Guid.NewGuid();
            IsActive = true;
            RegisterDate = DateTime.Now;
            RegisterDateSH = FrameWork.General.Date.Getdate();
        }


        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }

        public byte[] Content { get; set; }
        public int Lenght { get; set; }

        public ContentType ContentType { get; set; }
        public RefrenceType Refrence { get; set; }
        public bool IsActive { get; set; }


        public Guid OwnerUserId { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDateSH { get; set; }
    }
}