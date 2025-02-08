# Windows Form Application (Database)

## Overview  
This Windows Form Application is designed for managing a restaurant's table reservations. It provides user authentication and role-based access control, ensuring secure and efficient management of reservations. The application interface is in Hungarian.

## User Roles and Permissions  

### **Admin**  
- Can create new reservations.  
- Can update, delete, and view all reservations.  

### **User**  
- Can create new reservations under their own name.  
- Can view their own reservations.  

### **Guest**  
- Can only view existing reservations from the **Foglalás** (Reservations) table.  

This role-based structure ensures appropriate access control, enhancing both security and usability.

## Features  
- **Role-Based Access Control**: Admins, Users, and Guests have different levels of permissions.  
- **Database Integration**: Stores reservations securely in a database.  
- **User Authentication**: Login and registration system for secure access.  
- **Intuitive Interface**: Simple and easy-to-use design for efficient reservation management.  
