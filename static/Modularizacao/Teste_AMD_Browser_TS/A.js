﻿ // adaptação qualiom 
define("../Teste_AMD_Browser_TS/A",["require", "exports", '../Teste_AMD_Browser_TS/B', '../Teste_AMD_Browser_TS/D'], function(require, exports, mod_B, mod_D) {
    if (mod_B.OK != "OK")
        alert("ERRO NO B");
    if (mod_D.OK != "OK")
        alert("ERROx NO D");

    exports.A = "Ossud";
    exports.OK = "OsssK";

    document.write('Azdd');
});
//# sourceMappingURL=A.js.map
    