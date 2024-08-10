//loading table on document ready.

// defining the function loadDataTable. Refer datatables.net for code below.
var dataTable;
$(document).ready(function () {
    var url = window.location.search;
    if (url.includes("inprocess")) {
        loadDataTable("inprocess");
    }
    else {
        if (url.includes("completed")) {
            loadDataTable("completed");
        }
        else {
            if (url.includes("pending")) {
                loadDataTable("pending");
            }
            else {
                if (url.includes("approved")) {
                    loadDataTable("approved");
                }
                else {
                    loadDataTable("all");
                }
            }
        }
    }
});

function loadDataTable(status) {

    dataTable = $("#tableData").DataTable({
        "ajax": {
            "url": "/admin/order/getall?status=" + status,
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "id" },
            { "data": "name", "width": "20%" },
            { "data": "phoneNumber", "width": "20%" },
            { "data": "applicationUser.email", "width": "20%" },
            { "data": "orderStatus", "width": "10%" },
            { "data": "orderTotal", "width": "5%" },


            {
                "data": "id",
                "width": "20%",
                "render": function (data) {
                    return `<div class="w-100 btn-group btn-group-radius" role="group">
                                <a href="/Admin/Order/Details?orderId=${data}" class="btn custom-btn-black mx-2 rounded-2">
                                    <i class="bi bi-pencil-square">Edit</i>
                                </a>
                    </div>`
                       
                }
            }
        ]
    });
}



   