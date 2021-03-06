﻿/// <reference path="../lib/jasmine/jasmine.d.ts" />

import Fila = require("../../Chutzpah_AMD_app/services/Pilha");

describe("Fila", () => {
    var fila: Fila;
    beforeEach(() => {
        //ARRANGE

        fila = new Fila();
    });

    it("Quando a Fila for criada", () => {
        //ACT      
        expect(fila.itens_na_fila()).toBe(undefined);

    });

    it("Quando a Fila estiver vazia", () => {
        //ACT      
        expect(fila.itens_na_fila()).toBe(undefined);
    });
    it("Quando a vazia", () => {
        //ACT      
        expect(fila.itens_na_fila()).toBe(undefined);
    });
});