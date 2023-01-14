alter proc isValidCurrentMonth
@date date
as
 begin try
   begin tran

   declare @month varchar(100)
   declare @year varchar(100)

   declare @cur_month varchar(100)
   declare @cur_year varchar(100)
   set @month=datename(mm,@date)
   set @year=datename(yy,@date)

    set @cur_month=datename(mm,getdate())
   set @cur_year=datename(yy,GETDATE())

   declare @message varchar(100)
   if(@month=@cur_month and @year=@cur_year)
       begin
         set @message='valid';
         end
  else
    set @message='inValid';

    select @message as 'Message';

       

   commit tran

 end try

 begin catch
 rollback tran

 end catch


