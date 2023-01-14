create table payroll
(
payrollID int identity(1,1),
empID varchar(100),
BasicSalary decimal(18,2),
BonusAmount decimal(18,2),
Deductions decimal(18,2),
NetPay decimal(20,2),
Month varchar(100),
Year varchar(100)
)

drop table payroll
insert into payroll(empID,BasicSalary,BonusAmount,Deductions,NetPay,Month,Year)
values('EM108',200,100,100,200,'Decembef','2022')

select *from payroll
delete payroll

create proc readPayrollData
as
  select  employee.empID,empName as 'Employee Name',departName as 'Department',Designation,BasicSalary,BonusAmount,Deductions,NetPay,Month as 'Month Period', Year as 'Year'
from payroll inner join employee on
employee.empID=payroll.empID


create proc findUserReport
@username varchar(100)
as
  select *from users
  where username=@username


create proc showTops
@top int
as
  
    select  top (@top) employee.empID,empName as 'Employee Name',departName as 'Department',Designation,BasicSalary,BonusAmount,Deductions,NetPay,Month as 'Month Period', Year as 'Year'
from payroll inner join employee on
employee.empID=payroll.empID

create proc filterByPeriod 
@month varchar(100),
@year varchar(100)
as
  select  employee.empID,empName as 'Employee Name',departName as 'Department',Designation,BasicSalary,BonusAmount,Deductions,NetPay,Month as 'Month Period', Year as 'Year'
from payroll inner join employee on
employee.empID=payroll.empID
where Month=@month and Year=@year

create proc filterByDepart 
@depart varchar(100)
as
  select  employee.empID,empName as 'Employee Name',departName as 'Department',Designation,BasicSalary,BonusAmount,Deductions,NetPay,Month as 'Month Period', Year as 'Year'
from payroll inner join employee on
employee.empID=payroll.empID
where departName=@depart



create proc isGenerated 'Decembef','2022'
@month varchar(100),
@year varchar(100)
as


        select *from payroll
        where Month=@month and Year=@year

        select *from employee
        select *from Bonus
        select *from deductions
    declare @amount int


    CREATE PROC GeneratePayroll
    @empID varchar(100),
    @basicSalary decimal(20,2),
    @bonusAmount decimal(18,2),
    @deductions decimal(20,2),
    @netPay decimal(25,2),
    @month varchar(100),
    @year varchar(100)
    as
    begin try
      begin tran
            insert into payroll(empID,BasicSalary,BonusAmount,Deductions,NetPay,Month,Year)
values(@empID,@basicSalary,@bonusAmount,@deductions,@netPay,@month,@year)

      commit tran

    end try
      
    begin catch
     rollback tran
     declare @erroMessage varchar(100)
     set @erroMessage=ERROR_MESSAGE();
     select @erroMessage as 'Error'
    end catch
     

    -- GEENARETOIN
    create proc readPayrollJoinData
    as
select empID,salary, ISNULL(BonusAmount,0) as  'BonusAmount',ISNULL(Deductions,0) as 'Deductions',
(ISNULL(salary,0)+ISNULL(BonusAmount,0))-ISNULL(Deductions,0) as 'NetPay'
 from employee
full join deductions on
employee.empID=deductions.EmployeeID
   