


function CheckSelectedIdInDiv(divId,attribName) {
    
    var selected = [];
    $("#"+divId + " input:checked").each(function () {
        selected.push($(this).attr(attribName));
    });

    return selected;

}