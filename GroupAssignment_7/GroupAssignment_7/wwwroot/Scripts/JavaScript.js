jQuery(document).ready(function ($) {

    $("li").mouseenter(function () {
        var customerId = $(this).attr("customer-id");
        $.ajax({
            url: "/Customers/GetCustomerDetails",
            type: "GET",
            data: "id=" + customerId,
            success: function (html) {
                $("#Test").html(html);
            }
        });
    });

    $("li").mouseleave(function () {
        $("#Test").empty();
    });

    $("#btnGetAllCustomers").click(function() {
        $.ajax({
            url: "/Customers/GetCustomersJson",
            type: "GET",
            success: function (json) {
                $("#JsonDiv").html(json.length);
                alert(json.html);
            }
        });
    });

});