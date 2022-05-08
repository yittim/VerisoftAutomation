# VerisoftAutomation


The soulotion consists of two projects,
One of the infrastructure layer and one of the product layer pages and tests.
In the infrastructure project is divided into folders.
1.of abstract classes that contain a basis for each test and each page.
From which he inherited the tests and pages so that they would be uniform and prevent repetition of code.
2.The next folder is a helper folder that helps write neat code and currently contains a table auxiliary folder that can be reused in the pages of the table. If there was more time I would add here the Excel and path helper.
3.The next folder is all about the driver.
Creating the driver, the location of the driver itself and wrapping for all driver operations.

Other things I would add:
Adds TRY CATCH to all driver operations. And more detailed management of the errors
Makes CELL abstract for non-plain text CELL.
And lots more.
