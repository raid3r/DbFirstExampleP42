CREATE TABLE [dbo].[CarAdditionalOptions]
(
	[CarId] INT NOT NULL FOREIGN KEY REFERENCES Cars(Id),
	[OptionId] INT NOT NULL FOREIGN KEY REFERENCES AdditionalOptions(Id),
	PRIMARY KEY (CarId, OptionId)
)
