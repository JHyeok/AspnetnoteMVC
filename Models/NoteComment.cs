using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspnetNote.MVC6.Models
{
    public class NoteComments
    {
        /// <summary>
        /// 댓글 번호
        /// </summary>
        [Key]   // PK 설정
        public int NoteCommentsNo { get; set; }

        /// <summary>
        /// 댓글 내용
        /// </summary>
        [Required(ErrorMessage = "내용을 입력하세요.")]  // Not Null 설정
        public string CommentContents { get; set; }

        /// <summary>
        /// 작성자 번호
        /// </summary>
        [Required]  // Not Null 설정
        public int UserNo { get; set; }

        /// <summary>
        /// 게시물 번호
        /// </summary>
        [Required]  // Not Null 설정
        public int NoteNo { get; set; }

        //// User and Notes 조인
        //[ForeignKey("NoteNo")]  // FK 설정
        //public virtual Notes Notes { get; set; }
    }
}
