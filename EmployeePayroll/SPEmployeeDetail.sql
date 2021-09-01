
Create or Alter procedure spGetAllEmployee
as 
begin try
select * from employee_payroll
End Try
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_STATE() AS ErrorState,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_LINE() AS ErrorLine,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH 

CREATE OR ALTER procedure spInsertEmployeeDetails
(
	@Name VARCHAR(255),
	@Gender VARCHAR(1),
	@PhoneNumber VARCHAR(12),
	@Address VARCHAR(40),
	@Department VARCHAR(15),
	@BasicPay INT,
	@Deduction FLOAT,
	@TaxablePay FLOAT,
	@Tax FLOAT,
	@NetPay FLOAT,
	@StartDate date,
	@City VARCHAR(15),
	@Country VARCHAR(15)
)
AS
	Begin Try
			INSERT Into employee_payroll(Name,Gender,PhoneNumber, Address,Department,BasicPay,TaxablePay,Tax, NetPay, StartDate, City, Country) VALUES (@Name,@Gender,@PhoneNumber, @Address,@Department,@BasicPay,@TaxablePay,@Tax, @NetPay, @StartDate, @City, @Country)
	End Try
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_STATE() AS ErrorState,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_LINE() AS ErrorLine,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH 
