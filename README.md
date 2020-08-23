# winform-pagination
A simple windows form pagination UI, I created it base on my experience and solution to my problem. This is just a simple project which is not a final product of what I am using, I create this just to give you some inspiration of how I deal with UI and my algorithm to draw the controls, and how I manage those controls for a simple pagination.

I create this control with 2 mode of show the paging:

1, <b>ShowPages</b>: it will show a row of pages that user can select, but it will show base on <b>"CountShowPages"</b> property; so no matter how many pages you set to <b>"CountPage"</b> it         will only show between the range of <b>"CountShowPages"</b>. 

2, <b>ShowOnlyPageNumber</b>: it will only show the current page number, when user click next or previous it will increase or decrease accordingly.

<b>Note</b>: If you are going to deal with large database I would recommend you to use <b>ShowOnlyPageNumber</b>, since you don't need to count how many page that you will need control to reserve and draw if you use <b>ShowPages</b>.

<b>PS:</b> You can download the project then run to test and play around by yourself; I hope you can use this for you project if it fit, or you can use some of my solution to make something even better your own :D
