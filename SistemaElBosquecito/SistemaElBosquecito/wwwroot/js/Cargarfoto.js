﻿class Cargarfoto {
    archivo(evt, id) {
        let files = evt.target.files;
        let f = files[0];
        if (f.type.match('image.*')) {
            let reader = new FileReader();
            reader.onload = ((theFile) => {
                return (e) => {
                    document.getElementById(id).innerHTML = ['<img class="imageUser" scr="',
                        e.target.result, '" title="', escape(theFile.name), '"/>'].join('');
                }
            })(f);
            reader.readAsDataURL(f);
        }
    }
}