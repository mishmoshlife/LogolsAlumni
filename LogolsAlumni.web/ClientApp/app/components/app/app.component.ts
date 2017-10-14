import { Component, Inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Http } from '@angular/http';
import { Alumni } from '../../entities/alumni';
import { AlumniService } from '../../services/alumni.service';

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent {

    public alumni: Alumni[];
    public alumnus: Alumni;

    constructor (private http: Http, @Inject('BASE_URL') private baseUrl: string) { }


    ngOnInit() {
        this.reload();
    }

    reload()
    {
        
        let alumniService = new AlumniService(this.http, this.baseUrl);
        alumniService.getAll().subscribe(result => {
            this.alumni = result.json() as Alumni[];
        }, error => console.error(error));
    }

    onSubmitClicked(alumni: Alumni)
    {
        let alumniService = new AlumniService(this.http, this.baseUrl);
        alumniService.insert(alumni).subscribe(result => {
            this.reload();
        }, error => console.error(error));
    }


}
