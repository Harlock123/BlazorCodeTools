# BlazorCodeTools
A CRUD code creator simillar to my Code Complete aimed as Blazor

In this document I will show an approach to creation of new user-interface experiences that leverage tools I developed to take some of the drudgery out of the work needed to achieve this end goal. The tools specifically generate the code that hydrates the user interfaces with data in a similar way that the former controls employed in the older UI paradigms did automatically. With the modern UI paradigms leaving a significant portion of that work up to the developer.
For example. 
In the former UI paradigm, creation of many of the lists and grids of information on display to the end user was simply a matter of generation of a proper selection statement employing either SQL, or LINQ, or WQL or even a WEBAPI(REST or SOAP or CGI), and handing that to our TAIGridControl. The Grid executed whatever was necessary to retrieve the data asked for by the statement, and handled the displaying of that information in the User Interface. With Modern WEB/Browser based user interfaces a great deal of that repetitive and mechanical UI creation must be done by the developer. A simple grid on a screen requires that each column on the grid be explicitly declared with most UI toolkits and frameworks. Special formatting of things like Dates and Currency need to be further defined at the UI coding stage. These sorts of groups of information need to be turned into Collections of data objects that need to be defined. In those definitions it�s considered good form to also specify certain characteristics of the actual elements in these collections for validation purposes (IE Veracode scanning often flags these definitions as a problem without annotations like REQUIRED and STRINGLENGTH Maximums). Add to this set of burden the further requirement that in Browser based UI paradigms the need to also standup webservice endpoints to get the actual data to present, where formerly that data could be sought  right at the UI layer, a browser need to interface with a WEB SERVER over HTTPS exclusively forces this requirement. 

The required coding exercises to fulfill these requirements are not overly difficult to code for but they are largely mechanical and repetitive and thus rife for error when created via human hands. They are however precisely what computer tools are great for when applied to the task. Provided the computer tools exist in the first place. That is where tools like TAICODECOMPLETE and BLAZORCODETOOLS comes in handy. 17 + years ago I started with tools to generate code for me, and the rest of my team with TAICODECOMPLETE beginning its life as TAICODEGEN back at the turn of the century. The newest form of this technique is embodied in the BLAZORCODETOOLS application.