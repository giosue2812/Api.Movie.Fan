using System;


namespace DAL_Movie.ModelView.Notice
{
    public class NoticeByUser
    {  
        public bool IsActive { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateNotice { get; set; }
    }
}
