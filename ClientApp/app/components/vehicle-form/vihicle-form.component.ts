import { MakeService } from './../../Services/make.service';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';



@Component({
  selector: 'app-vihicle-form',
  templateUrl: './vihicle-form.component.html',
  styleUrls: ['./vihicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {

  constructor(private makeservice : MakeService) { }

  makes: any[];

  vehicle: any = {};

  models: any[];



  ngOnInit() {

     this.makeservice.getMakes()
    .subscribe(makes => 
    {
      this.makes = makes;
       console.log("Makes: ",this.makes)
    })
  }

  onMakeChange() {

      var selectedMake = this.makes.find(m => m.id == this.vehicle.make);

      this.models = selectedMake.models;
  }

}
