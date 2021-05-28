//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Quiz
    {
        public Quiz()
        {
            this.Participants = new HashSet<Participant>();
            this.QuizAttempts = new HashSet<QuizAttempts>();
            this.Questions = new HashSet<Question>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int AdminUserId { get; set; }
        public int TopicId { get; set; }
    
        protected virtual AdminUser AdminId { get; set; }
        protected virtual ICollection<Participant> Participants { get; set; }
        protected virtual Topic Topic { get; set; }
        protected virtual ICollection<QuizAttempts> QuizAttempts { get; set; }
        protected virtual ICollection<Question> Questions { get; set; }
    }
}