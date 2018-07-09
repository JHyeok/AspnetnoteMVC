// Write your JavaScript code.

$(".editor").trumbowyg({
    lang: 'ko',
    btnsDef: {
        ImageUpload: {
            dropdown: ['insertImage', 'upload'],
            ico:'insertImage'
        }
    },
    btns: [
        ['viewHTML'],
        ['undo', 'redo'], // Only supported in Blink browsers
        ['formatting'],
        ['strong', 'em', 'del'],
        ['superscript', 'subscript'],
        ['link'],
        ['insertImage', 'ImageUpload'],
        ['justifyLeft', 'justifyCenter', 'justifyRight', 'justifyFull'],
        ['unorderedList', 'orderedList'],
        ['horizontalRule'],
        ['removeformat'],
        ['fullscreen']
    ]
});

