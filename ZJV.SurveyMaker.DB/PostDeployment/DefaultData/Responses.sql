Begin
Declare @responseAnswerId uniqueidentifier;
Declare @responseQuestionId uniqueidentifier;

select @responseQuestionId = Id from tblQuestion where Question = 'What color is #51DFFF';
Select @responseAnswerId = Id from tblAnswer where Answer = 'Sky Blue Crayola';


Insert into tblResponse values (NEWID(), @responseQuestionId, @responseAnswerId, GETDATE());

select @responseQuestionId = Id from tblQuestion where Question = 'What color is #FF52DF';
Select @responseAnswerId = Id from tblAnswer where Answer = 'Purple Pizzazz';
Insert into tblResponse values (NEWID(), @responseQuestionId, @responseAnswerId, GETDATE());

select @responseQuestionId = Id from tblQuestion where Question = 'What color is #DFFF52'
Select @responseAnswerId = Id from tblAnswer where Answer = 'Arctic Lime'

Insert into tblResponse values (NEWID(), @responseQuestionId, @responseAnswerId, GETDATE());

select @responseQuestionId = Id from tblQuestion where Question = 'What color is #FF5254';
Select @responseAnswerId = Id from tblAnswer where Answer = 'Tart Orange';

Insert into tblResponse values (NEWID(), @responseQuestionId, @responseAnswerId, GETDATE());

select @responseQuestionId = Id from tblQuestion where Question = 'What color is #5254FF';
Select @responseAnswerId = Id from tblAnswer where Answer = 'Majorelle Blue';

Insert into tblResponse values (NEWID(), @responseQuestionId, @responseAnswerId, GETDATE());
End