$(function () {
    $.ajax({
        type: "POST",
        url: "/Home/HouseholdTable",
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: OnSuccess
    });
});

function OnSuccess(response) {
    $('#householdDatatable').dataTable({
        "bFilter": false,
        "bLengthChange": false,
        'iDisplayLength': 18,
        data: response,
        columns: [{ 'data': 'hshd_num' },
        { 'data': 'loyalty_flag' },
        { 'data': 'age_range' },
        { 'data': 'marital_status' },
        { 'data': 'income_range' },
        { 'data': 'homeower_desc' },
        { 'data': 'hshd_composition' },
        { 'data': 'hshd_size' },
        { 'data': 'children' }
        ]
    });
};

$('#householdDatatable').parent().addClass('table-responsive');