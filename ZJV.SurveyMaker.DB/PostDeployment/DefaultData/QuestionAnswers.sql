Begin
Declare @AnswerId uniqueidentifier;
Declare @QuestionId uniqueidentifier;
Declare @IncorrectId uniqueidentifier;
Declare @Incorrect2Id uniqueidentifier;

select @QuestionId = Id from tblQuestion where Question = 'What color is #51DFFF'
Select @AnswerId = Id from tblAnswer where Answer = 'Sky Blue Crayola'
Select @IncorrectId = Id from tblAnswer where Answer = 'Pancakes'
Select @Incorrect2Id = Id from tblAnswer where Answer = 'Waffles'

INSERT INTO tblQuestionAnswer(Id, QuestionId, AnswerId, IsCorrect) values (NEWID(), @QuestionId, @AnswerId, 1)
INSERT INTO tblQuestionAnswer(Id, QuestionId, AnswerId, IsCorrect) values (NEWID(), @QuestionId, @IncorrectId, 0)
INSERT INTO tblQuestionAnswer(Id, QuestionId, AnswerId, IsCorrect) values (NEWID(), @QuestionId, @Incorrect2Id, 0)

select @QuestionId = Id from tblQuestion where Question = 'What color is #FF52DF'
Select @AnswerId = Id from tblAnswer where Answer = 'Purple Pizzazz'
Select @IncorrectId = Id from tblAnswer where Answer = 'French Toast'
Select @Incorrect2Id = Id from tblAnswer where Answer = 'Grits'

INSERT INTO tblQuestionAnswer(Id, QuestionId, AnswerId, IsCorrect) values (NEWID(), @QuestionId, @AnswerId, 1)
INSERT INTO tblQuestionAnswer(Id, QuestionId, AnswerId, IsCorrect) values (NEWID(), @QuestionId, @IncorrectId, 0)
INSERT INTO tblQuestionAnswer(Id, QuestionId, AnswerId, IsCorrect) values (NEWID(), @QuestionId, @Incorrect2Id, 0)

select @QuestionId = Id from tblQuestion where Question = 'What color is #DFFF52'
Select @AnswerId = Id from tblAnswer where Answer = 'Arctic Lime'
Select @IncorrectId = Id from tblAnswer where Answer = 'Pancakes'
Select @Incorrect2Id = Id from tblAnswer where Answer = 'Oatmeal'

INSERT INTO tblQuestionAnswer(Id, QuestionId, AnswerId, IsCorrect) values (NEWID(), @QuestionId, @AnswerId, 1)
INSERT INTO tblQuestionAnswer(Id, QuestionId, AnswerId, IsCorrect) values (NEWID(), @QuestionId, @IncorrectId, 0)
INSERT INTO tblQuestionAnswer(Id, QuestionId, AnswerId, IsCorrect) values (NEWID(), @QuestionId, @Incorrect2Id, 0)

select @QuestionId = Id from tblQuestion where Question = 'What color is #FF5254'
Select @AnswerId = Id from tblAnswer where Answer = 'Tart Orange'
Select @IncorrectId = Id from tblAnswer where Answer = 'Scrambled Eggs'
Select @Incorrect2Id = Id from tblAnswer where Answer = 'Waffles'

INSERT INTO tblQuestionAnswer(Id, QuestionId, AnswerId, IsCorrect) values (NEWID(), @QuestionId, @AnswerId, 1)
INSERT INTO tblQuestionAnswer(Id, QuestionId, AnswerId, IsCorrect) values (NEWID(), @QuestionId, @IncorrectId, 0)
INSERT INTO tblQuestionAnswer(Id, QuestionId, AnswerId, IsCorrect) values (NEWID(), @QuestionId, @Incorrect2Id, 0)
select @QuestionId = Id from tblQuestion where Question = 'What color is #5254FF'
Select @AnswerId = Id from tblAnswer where Answer = 'Majorelle Blue'
Select @IncorrectId = Id from tblAnswer where Answer = 'Grits'
Select @Incorrect2Id = Id from tblAnswer where Answer = 'Waffles'

INSERT INTO tblQuestionAnswer(Id, QuestionId, AnswerId, IsCorrect) values (NEWID(), @QuestionId, @AnswerId, 1)
INSERT INTO tblQuestionAnswer(Id, QuestionId, AnswerId, IsCorrect) values (NEWID(), @QuestionId, @IncorrectId, 0)
INSERT INTO tblQuestionAnswer(Id, QuestionId, AnswerId, IsCorrect) values (NEWID(), @QuestionId, @Incorrect2Id, 0)

End