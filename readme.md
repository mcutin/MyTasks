# About

A simple short term to do list. Database is a XML file, since there is no such huge amount of data.

![Example screenshot](Assets/Example.jpg)
# To be implemented

* Edit tasks.
* Remove completed tasks.

# Known issues

* When any day is clicked in Short Term Plan, several days (including the one clicked) have their contents deleted. I guess it happens due to the disable/enable used in each one to avoid showing the cursor inside the RichTextBox object.
* When order changes highlighted day in Short Term Plan does not update.
* In Edit Task dialog box, priority is not loading and when Cancel button is clicked all tasks are loaded agagin without deleting the previously existing entries from datagridview.
* In New Task dialog box, When Cancel button is clicked all tasks are loaded agagin without deleting the previously existing entries from datagridview.