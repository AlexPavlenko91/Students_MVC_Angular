import { Component , OnInit} from '@angular/core';
import { SubjectModel } from '../_models/SubjectModel';
import { SubjectService } from '../_services/SubjectService';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
 public services: SubjectModel[];
  constructor(public subjectService: SubjectService) {
    debugger;
  }
  ngOnInit() {
    
    debugger;
    let services = this.subjectService.getAllItems().subscribe(data => {
      this.services = data as SubjectModel[];
    });

  }
}
