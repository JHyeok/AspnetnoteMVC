using AspnetNote.MVC6.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspnetNote.MVC6.ViewModel
{
    public class NoteViewModel
    {
        // 1 페이지에서 2개의 모델을 보여줄 때 , 뷰모델 이용
        public IEnumerable<Notes> Notes { get; set; }
        public IEnumerable<NoteComments> NoteComments { get; set;}
    }
}
