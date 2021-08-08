# ContactsWebApp
A simple contact registration app writen in Blazor

# Requirements

- Visual Studio 2019 or higher installed
- .Net 5 SDK installed

# How to build

- Set ContactsWebApp.Server as the inicialization project
- Run
- Enjoy! :)

# Premisses/Assumptions
- As there is no relevant details about the contact itself, it was considered there is no need for a contact's list page for it.
- An address class was assumed to be needed as either Natural Person or Legal Person share the same details
- The Blazor choice for this application occured because I heard a lot from Microsoft's MVP staff that this would be 
a very promissing technology and Microsoft has been investing a lot of effort to develop it, so I wished to give it a try, 
that was my first time developing using Blazor and it was quite interesting, the only nuisance I found was: as the client side it's all compiled inside the Web Assembly,
on every layout change the project must be restarted on Visual Studio, which is not needed on JavaScript based frameworks. 
On the other hand, it's quicker, smaller and easy do develop.




