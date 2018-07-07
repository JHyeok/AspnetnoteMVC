using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspnetNote.MVC6.Models
{
    public class Note
    {
        /// <summary>
        /// 게시물 번호
        /// </summary>
        [Key]   // PK 설정
        public int NoteNo { get; set; }

        /// <summary>
        /// 게시물 제목
        /// </summary>
        [Required]  // Not Null 설정
        public string NoteTitle { get; set; }

        /// <summary>
        /// 게시물 내용
        /// </summary>
        [Required]  // Not Null 설정
        public string NoteContents { get; set; }

        /// <summary>
        /// 작성자 번호
        /// </summary>
        [Required]  // Not Null 설정
        public int UserNo { get; set; }


        // User 조인
        [ForeignKey("UserNo")]    // FK 설정
        public virtual User User { get; set; }
        //virtual : 레이지 로딩, 비동기적으로 가져오는 의미에서
        //virtual을 선언, 선언안해줘도 정상적으로 출력되지만
        //레이지 로딩 하기 위해 virtual 키워드를 넣어주는 것을 권장함 
    }
}
