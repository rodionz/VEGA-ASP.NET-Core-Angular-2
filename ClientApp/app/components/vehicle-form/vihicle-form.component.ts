import { MakeService } from './../../Services/make.service';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { FeatureService } from '../../Services/feature.service';



@Component({
  selector: 'app-vihicle-form',
  templateUrl: './vihicle-form.component.html',
  styleUrls: ['./vihicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {

  constructor(private makeservice : MakeService,
  private featureService : FeatureService) { }

  makes: any[];

  vehicle: any = {};

  models: any[] = [];

  features: any[];

  ngOnInit() {

     this.makeservice.getMakes()
    .subscribe(makes =>  
      this.makes = makes);

      this.featureService.getFeatures()
      .subscribe(feature => this.features = feature)
  }

  onMakeChange() {

     var selectedMake = this.makes.find(m => m.id == this.vehicle.make);   
      this.models = selectedMake ? selectedMake.models : [];
  }

}
