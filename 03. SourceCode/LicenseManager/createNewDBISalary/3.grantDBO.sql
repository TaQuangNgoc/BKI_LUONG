use dbname

CREATE USER username FROM LOGIN username;
exec sp_addrolemember 'db_owner', 'username';
