# Exam Management System 📝

An online system that enables students to take exams 🖥️, view results 📊, while admins manage staff 👩‍💼 and subjects 📚, and staff add questions ✏️ to assigned subjects. The project focuses on **role-based access**, **database management**, and a **user-friendly interface**.

---

## Key Features

- **Role-Based Access** 🔑  
  - Users are assigned roles: Admin, Staff, or Student.  
  - Access to dashboards and features depends on the role.

- **Home Page** 🏠  
  - Options: **Login** and **Cancel**.  
  - Login redirects users to role-specific dashboards.

- **RoleMaster Table** 📋  
  - Defines user roles:  
    - `Admin`  
    - `Staff`  
    - `Student`  
  - Determines which dashboard the user sees after login.

- **Student Functionality** 🎓  
  - Take exams  
  - View exam results  

- **Staff Functionality** 👨‍🏫  
  - Add and manage questions for assigned subjects  

- **Admin Functionality** 🧑‍💼  
  - Manage staff and subjects  
  - Monitor system activities  

- **Database Management** 💾  
  - Stores user info, exam questions, and results efficiently using **ADO.NET**.

- **User-Friendly Interface** 🖥️  
  - Simple navigation for all users  

---

## Technologies Used

- **Frontend:** HTML, CSS, JavaScript  
- **Backend:** ASP.NET (C#) using **ADO.NET** for database operations  
- **Database:** SQL Server  

---

## How It Works

1. **Login System** 🔑  
   - Users enter username and password.  
   - System verifies credentials using **ADO.NET**.  
   - User role is fetched from **RoleMaster** table.  
   - Redirects to the appropriate dashboard:  
     - Admin → Admin Dashboard 👩‍💼  
     - Staff → Staff Dashboard 👨‍🏫  
     - Student → Student Dashboard 🎓  

2. **Dashboard Functionalities**  
   - **Admin:** Add/manage staff and subjects, view reports  
   - **Staff:** Add/manage questions for assigned subjects  
   - **Student:** Take exams and view results  


