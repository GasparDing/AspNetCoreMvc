# ASP.NET Core MVC and Entity Framework Core
�bVisual Studio �����ҤU�ϥ� ASP.NET Core MVC �H�� Entity Framework Core ���J���x��оǱM��
Getting started with ASP.NET Core MVC and Entity Framework Core using Visual Studio .

�}�o�u�� (IDE)�GVisual Studio 2017
�ج[ (Framework)�G.Net Core 2.0

# Conventions �D�� / ����

�]���� Conventions �� Entity Framework �� ���]�A�ڭ̥i�H�g�֤֪�Code�A�� Entity Framework �i�H���ڭ̦۰ʫإߧ��㪺Database�A�ӳo�ǺD��/�����p�H�U�|�I�G
The amount of code you had to write in order for the Entity Framework to be able to create a complete database for you is minimal because of the use of conventions, or assumptions that the Entity Framework makes.

1. �ŧi�� DbSet�ݩʪ� entity �H�W�١A�Ϥ��h�H class �W�� �@����ƪ��R�W�C
The names of DbSet properties are used as table names. For entities not referenced by a DbSet property, entity class names are used as table names.
2. �C�� Entity ���ݩʦW�٥����W�٨M�w (�]�N�O�A models ���ŧi���U�ӦW��)
Entity property names are used for column names.
3. �W�� "ID" �� "ClassnameID" �|�Q�۰ʵ��� PrimaryKey
Entity properties that are named ID or classnameID are recognized as primary key properties.
4. �Y�w�R�W "ID" ��P.Key�A�h�R�W�� "ClassnameID" ���ݩʷ|�Q��@ ForeignKey�AForeignKey�]�i�H²�g�� "ClassID"�A�b "Enrollment.cs" ��������ԲөR�W�W�h�C
A property has named as ID and P.Key in the original entity is interpreted as a foreign key property in other entity if it's named "ClassID". Foreign key properties can also be named simply.More detail please reference to "Enrollment.cs".