ALTER TABLE [dbo].[tblResponse]
	ADD CONSTRAINT [Response_Answer]
	FOREIGN KEY (AnswerId)
	REFERENCES [tblAnswer] (Id)
