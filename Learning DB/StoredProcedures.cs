﻿using System;
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
        
        
        public static string InsertAdmin = "spInsertAdmin";
        public static string UpdateAdmin = "spUpdateAdmin";
        public static string ActivateAdmin = "spAdminAccountActivation";
        
        public static string InsertInstructor = "spInsertInstructor";
        public static string UpdateInstructor = "spUpdateInstructor";
        public static string ActivateInstructor = "spInstructorAccountActivation";

        public static string InsertStudent = "spInsertStudent"; 
    }
}
