

function MoveToRecylebin(actionurl,senids, onDone, onFail) {
    $.ajax({
        type: 'POST',
        url: actionurl,
        data: { senids: senids },
        traditional: true,
        dataType: "json",
        async: false,
        success:
            function (result) { onDone(result); },
        error:
            function (result) {
                console.log(result);
                onFail(result);
            }
    });

}


