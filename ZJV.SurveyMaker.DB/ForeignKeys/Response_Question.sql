ALTER TABLE [dbo].[tblResponse]
	ADD CONSTRAINT [Response_Question]
	FOREIGN KEY (QuestionId)
	REFERENCES [tblQuestion] (Id)
