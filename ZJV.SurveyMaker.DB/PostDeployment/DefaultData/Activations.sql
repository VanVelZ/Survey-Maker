Begin
Declare @activationQuestionId uniqueidentifier

select @activationQuestionId = Id from tblQuestion where Question = 'What color is #51DFFF'
Insert into tblActivation values (NEWID(), @activationQuestionId, GETDATE(), '2020-11-11', 'aaaaaa')

select @activationQuestionId = Id from tblQuestion where Question = 'What color is #DFFF52'
Insert into tblActivation values (NEWID(), @activationQuestionId, GETDATE(), '2020-11-11', 'bbbbbb')
select @activationQuestionId = Id from tblQuestion where Question = 'What color is #FF5254'
Insert into tblActivation values (NEWID(), @activationQuestionId, GETDATE(), '2020-11-11', 'cccccc')

select @activationQuestionId = Id from tblQuestion where Question = 'What color is #FF52DF'
Insert into tblActivation values (NEWID(), @activationQuestionId, GETDATE(), '2020-11-11', 'dddddd')
End