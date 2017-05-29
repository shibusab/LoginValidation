# LoginValidation
Sample Code for Validating Login

Rules:
  If user is authenticated
   check if active,<br/>
   then is locked,<br/>
   then passed allowed (x) login attempts within last (y) minutes, then lock or unlock if it passed<br/>
   then check for Password is Expired after (x) days of last password changed<br/>
   
   This can be a chain of IF ELSE
   
  <b> Refactored those chained IF's to Strategy Pattern </b>
   
   NOTE: Reads User Info from an XML file / or write your own provider
