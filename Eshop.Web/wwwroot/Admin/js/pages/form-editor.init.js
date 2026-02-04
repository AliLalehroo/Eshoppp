ClassicEditor.create(document.querySelector("#ckeditor-classic"),
    {
        toolbar: {
            items: [
                'heading',
                '|',
                'bold',
                'italic',
                'link',
                '|',
                'fontSize',
                'fontColor',
                'fontBackgroundColor',
                '|',
                'blockQuote',
                'insertTable',
                'undo',
                'redo',
                'bulletedList',
                'numberedList',
                'todoList',
                'outdent',
                'indent'
            ]
        },
        language: 'fa',
        table: {
            contentToolbar: [
                'tableColumn',
                'tableRow',
                'mergeTableCells'
            ]
        },
        licenseKey: '',
        simpleUpload: {
            // The URL that the images are uploaded to.
            uploadUrl: '/Manager/Uploader/UploadImage'
        }
    })
    .then(function (e) {
        e.ui.view.editable.element.style.height = "100px";
    })
    .catch(function (e) { console.error(e) });


ClassicEditor.create(document.querySelector("#ckeditor-classic-2"),
        {
            toolbar: {
                items: [
                    'heading',
                    '|',
                    'bold',
                    'italic',
                    'link',
                    '|',
                    'fontSize',
                    'fontColor',
                    'fontBackgroundColor',
                    '|',
                    'blockQuote',
                    'insertTable',
                    'undo',
                    'redo',
                    'bulletedList',
                    'numberedList',
                    'todoList',
                    'outdent',
                    'indent'
                ]
            },
            language: 'fa',
            table: {
                contentToolbar: [
                    'tableColumn',
                    'tableRow',
                    'mergeTableCells'
                ]
            },
            licenseKey: '',
            simpleUpload: {
                // The URL that the images are uploaded to.
                uploadUrl: '/Manager/Uploader/UploadImage'
            }
        })
    .then(function (e) {
        e.ui.view.editable.element.style.height = "100px";
    })
    .catch(function (e) { console.error(e) });

ClassicEditor.create(document.querySelector("#ckeditor-classic-3"),
        {
            toolbar: {
                items: [
                    'heading',
                    '|',
                    'bold',
                    'italic',
                    'link',
                    '|',
                    'fontSize',
                    'fontColor',
                    'fontBackgroundColor',
                    '|',
                    'imageUpload',
                    'blockQuote',
                    'insertTable',
                    'undo',
                    'redo',
                    'bulletedList',
                    'numberedList',
                    'todoList',
                    'outdent',
                    'indent'
                ]
            },
            language: 'fa',
            table: {
                contentToolbar: [
                    'tableColumn',
                    'tableRow',
                    'mergeTableCells'
                ]
            },
            licenseKey: '',
            simpleUpload: {
                // The URL that the images are uploaded to.
                uploadUrl: '/Manager/Uploader/UploadImage'
            }
        })
    .then(function (e) {
        e.ui.view.editable.element.style.height = "100px";
    })
    .catch(function (e) { console.error(e) });

ClassicEditor.create(document.querySelector("#ckeditor-classic-4"),
        {
            toolbar: {
                items: [
                    'heading',
                    '|',
                    'bold',
                    'italic',
                    'link',
                    '|',
                    'fontSize',
                    'fontColor',
                    'fontBackgroundColor',
                    '|',
                    'imageUpload',
                    'blockQuote',
                    'insertTable',
                    'undo',
                    'redo',
                    'bulletedList',
                    'numberedList',
                    'todoList',
                    'outdent',
                    'indent'
                ]
            },
            language: 'fa',
            table: {
                contentToolbar: [
                    'tableColumn',
                    'tableRow',
                    'mergeTableCells'
                ]
            },
            licenseKey: '',
            simpleUpload: {
                // The URL that the images are uploaded to.
                uploadUrl: '/Manager/Uploader/UploadImage'
            }
        })
    .then(function (e) {
        e.ui.view.editable.element.style.height = "100px";
    })
    .catch(function (e) { console.error(e) });

ClassicEditor.create(document.querySelector("#user-ckeditor-classic"),
        {
            toolbar: {
                items: [
                    'heading',
                    '|',
                    'bold',
                    'italic',
                    '|',
                    'fontColor',
                    'fontBackgroundColor',
                    '|',
                    'blockQuote',
                    'insertTable',
                    'bulletedList',
                    'numberedList',
                ]
            },
            language: 'fa',
            table: {
                contentToolbar: [
                    'tableColumn',
                    'tableRow',
                    'mergeTableCells'
                ]
            },
            licenseKey: '',
        })
    .then(function (e) {
        e.ui.view.editable.element.style.height = "100px";
    })
    .catch(function (e) { console.error(e) });
