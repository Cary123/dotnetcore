$(document).ready(function() {
    $("form").submit(function (e) {
        e.preventDefault();
        alert("aaaa");
        $.ajax({
            url: "/api/reservation",
            contentType: "application/json",
            dataType :"json",
            method: "POST",
            // data:{
            //     "clientName":this.elements["ClientName"].value,
            //     "location": this.elements["Location"].value
            // },
            data: JSON.stringify({
                clientName: this.elements["ClientName"].value,
                location: this.elements["Location"].value
            }),
            success: function (data) {
                alert("ok");
                addTableRow(data);
            },
            error: function()
            {
                 alert("errr");
            }
        });
    });
});

var addTableRow = function (reservation) {
    alert(reservation.reservationId);
    $("#tbody_Reservaton").append("<tr><td>" + reservation.reservationId + "</td><td>"
        + reservation.clientName + "</td><td>"
        + reservation.location + "</td></tr>");
}