﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QuestionStorage.Models.Quizzes;

namespace QuestionStorage.Models.Courses
{
    public class Course
    {
        public Course()
        {
            UsersCourses = new HashSet<UsersCourses>();
            Questions = new HashSet<Questions.Question>();
        }
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Course title is required.")]
        [StringLength(256)]
        [MinLength(1)]
        public string Name { get; set; }

        public virtual ICollection<UsersCourses> UsersCourses { get; set; }
        [InverseProperty("Course")]
        public virtual ICollection<Questions.Question> Questions { get; set; }
        
        [InverseProperty("Course")]
        public virtual ICollection<Quiz> Quizzes { get; set; }
    }
}
