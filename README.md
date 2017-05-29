# LoginValidation
Sample Code for Validating Login

Rules:
  If user is authenticated
   check if active,
   then is locked,
   then passed allowed (x) login attempts within last (y) minutes, then lock or unlock if it passed
   then check for Password is Expired after (x) days of last password changed
   
   This can be a chain of IF ELSE
   
   Refactored those chained IF's to Strategy Pattern
   
   NOTE: Reads User Info from an XML file / or write your own provider
