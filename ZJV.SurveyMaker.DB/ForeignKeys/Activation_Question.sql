ALTER TABLE [dbo].[tblActivation]
	ADD CONSTRAINT [Activation_Question]
	FOREIGN KEY (QuestionId)
	REFERENCES [tblQuestion] (Id)
