

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

function RemoveDocTitles(actionurl, titids,folId, onDone, onFail) {
    $.ajax({
        type: 'POST',
        url: actionurl,
        data: {
            titIds: titids,
            ownerFolId: folId
        },
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

function SendDocuments(actionurl,docSendModel, onDone, onFail) {
    $.ajax({
        type: 'POST',
        url: actionurl,

        data: {
            docSendModel          
        },
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

function SendWithDocTitles(actionurl, docId, folId, onDone, onFail) {
    $.ajax({
        type: 'POST',
        url: actionurl,
        data: {
            docId: docId,
            ownerFolId: folId
        },
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