$(document).ready(function(){
    $("#btnPost").click(function(){
       $.ajax({
           url : "/api/users",
           type : "post",
           async : true,
           timeout : 5000,
           contentType : "application/json",
                       // data: JSON.stringify({
            //     clientName: this.elements["ClientName"].value,
            //     location: this.elements["Location"].value
            // }),
           data:JSON.stringify({
               id:10010,
               name:"hello",
               password:"123456"
           }),
           dataType :"json",
           success : function(data)
           {
               if (data.resultCode == 1)
               {
                $("#textArea").innerHtml("<p>"+ data.resultCode +"</p>" +
                "<p>"+ data.message +"</p>" +
                "<p>"+ data.content.Id +"</p>" +
                "<p>"+ data.content.Name +"</p>" +
                "<p>"+ data.content.Password +"</p>");
               }
               else
               {
                   alert("Api error!");
               }             
           },
           error : function()
           {
                alert("errr");
           },
           statusCode : {404 : function()
           {
              alert("Page not found");  
           }}

       });
    });

    $("#btnPost").click(function(){
        
    });

});