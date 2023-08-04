# ULAPI

User Loggin API

Currently 4 endpoints, add(/addUser), remove(/removeUser), update(/updateUser) and validate(/validateUser) user
only validate return something, true or false

working on responsiveness for the other 3 endpoints

/addUser: takes a name, password and email

/removeUser: takes a name and password, if correct removes the user from db using stored procedure

/updateUser: takes name, password and 3 optional parameters, newName, newPassword and newEmail

/validateUser: takes name and password and return bool
