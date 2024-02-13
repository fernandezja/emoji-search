window.clipboardCopy = {
    copyText: function (text) {
        navigator.clipboard.writeText(text).then(function () {
            //TODO: Callback
        })
        .catch(function (error) {
            alert(error);
        });
    }
};