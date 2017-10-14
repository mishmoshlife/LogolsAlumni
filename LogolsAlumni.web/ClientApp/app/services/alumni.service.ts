import { Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Alumni } from '../entities/alumni';

export class AlumniService {
    http: Http;
    baseUrl: string;
    controller: string = "api/Alumni/";

    constructor(http: Http, baseUrl: string) {
        this.http = http;
        this.baseUrl = baseUrl;
    }

    public getAll() {
        return this.http.get(this.baseUrl + this.controller);
    }

    public getAlumni(id: number) {
        return this.http.get(this.baseUrl + this.controller + 'Alumni/' + id);
    }

    public get(id: number) {
        return this.http.get(this.baseUrl + this.controller + id);
    }

    public update(alumni: Alumni) {
        return this.http.put(this.baseUrl + this.controller, alumni);
    }

    public insert(alumni: Alumni) {
        return this.http.post(this.baseUrl + this.controller, alumni);
    }

    
}