$(document).ready(function () {

    var table = $('#comDataTables').DataTable();
    //var tableTools = new $.fn.dataTable.tableTools(table, {
    //    'sSwfPath': '//cdn.datatables.net/tabletools/2.2.4/swf/copy_csv_xls_pdf.swf',
    //    'aButtons': ['csv']
    //});
    //$(tableTools.fnContainer()).insertBefore("#DataTables_Table_0_wrapper");
    table.destroy();
    //debugger;
    table = $("#comDataTables").DataTable({
        "ajax": {
            "url": "/Home/GetCompanies",
            "type": "Get",
            "dataType": "json"
        },
        "columns": [
            { "data": "id", "id": "Id", "autoWidth": true },
            { "data": 'name', "name": 'Name', "autoWidth": true },
            { "data": "contact_Number", "name": "Contact_Number", "autoWidth": true },
            { "data": "registration_No", "name": "Registration_No", "autoWidth": true },
            { "data": "active", "name": "Active", "autoWidth": true },
            {
                "data": null, render: function (data, type, row) {
                    return '<a href="/Company/Index?Id=' + data.id + '"><button type="button" class="btn btn-info btn-xs">Edit</button></a>&nbsp;&nbsp;&nbsp;<a href="/Company/DeleteCompany?Id=' + data.id +'"><button type="button" class="btn btn-danger btn-xs"  onclick="return confirmit();">Delete</button></a>'
                   // return '<!-- Button trigger modal --><button type="button" class="btn btn-info" data-toggle="modal" data-target="#exampleModal">Edit</button>&nbsp;&nbsp;<button type="button" class="btn btn-danger" data-toggle="modal" data-target="#exampleModal">Delete</button><!-- Modal --><div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true"><div class="modal-dialog" role="document"><div class="modal-content"><div class="modal-header"><h5 class="modal-title" id="test2">' + data.proj_name + '</h5><button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button></div><div class="modal-body">...</div><div class="modal-footer"><button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button><button type="button" class="btn btn-primary">Save changes</button></div></div></div></div>';
                }
            }
        ]
    })
});