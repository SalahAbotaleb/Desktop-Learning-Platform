using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learning_DB
{
    public class StoredProcedures
    {
        public static string Loginstudent = "SelectStudent";
        public static string LoginInstructor = "SelectInstructor";
        public static string Loginadmin = "Selectadmin";
        public static string SelectClassroomByCode = "SearchClassroomForStudent";
        public static string EnrollStudentByAccessCode = "EnrollStudentByAccessCode";
        public static string SelectInstructorsForClassByCode = "SelectInstructorsForClassByCode";
        public static string SelectInstructorsForClassByID = "SelectInstructorsForClassByID";
        public static string SelectClassInfoForStudent = "SelectClassroomTitleCourseNameByID";
        public static string SelectClassforInstructorbyID = "SelectClassforInstructorbyID";


        public static string InsertAdmin = "spInsertAdmin";
        public static string UpdateAdmin = "spUpdateAdmin";
        public static string ActivateAdmin = "spAdminAccountActivation";
        
        public static string InsertInstructor = "spInsertInstructor";
        public static string UpdateInstructor = "spUpdateInstructor";
        public static string ActivateInstructor = "spInstructorAccountActivation";

        public static string InsertStudent = "spInsertStudent"; 
        public static string UpdateStudent = "spUpdateStudent";
        public static string ActivateStudent = "spStudentAccountActivation";

        public static string InsertCourse = "spInsertCourse";
        public static string UpdateCourse = "spUpdateCourse";
        
        public static string ManageByAdmin = "SelectManagingByAdmin";
        public static string ManageDoneOnInstructor = "SelectManageDoneOnInstructor";
        public static string ManageDoneOnStudent = "SelectManageDoneOnStudent";

        public static string AddClassroom = "spCreateClassroom";
        public static string InsertSumbission = "spSubmitAssignment";

        public static string CheckExamAvailability = "spCheckExamAvailability";

        public static string CommentOnPost = "spCommentOnPost";
    }
}
