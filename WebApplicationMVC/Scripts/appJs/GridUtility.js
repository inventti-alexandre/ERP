


function CheckSelectedSenIdInDiv(divId) {
    
    var selected = [];
    $("#"+divId + " input:checked").each(function () {
        selected.push($(this).attr("Senid"));
    });

    return selected;

}

function CheckSelectedDocIdInDiv(divId) {

    var selected = [];
    $("#" + divId + " input:checked").each(function () {
        selected.push($(this).attr("docId"));
    });

    return selected;

}


function CheckSelectedFolIdInDiv(divId) {

    var selected = [];
    $("#" + divId + " input:checked").each(function () {
        selected.push($(this).attr("folid"));
    });

    return selected;

}

function CheckSelectedPrsIdInDiv(divId) {

    var selected = [];
    $("#" + divId + " input:checked").each(function () {
        selected.push($(this).attr("prsid"));
    });

    return selected;

}