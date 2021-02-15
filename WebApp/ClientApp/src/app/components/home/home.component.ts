import { Component , OnInit} from '@angular/core';
import { SubjectModel } from '../../_models/SubjectModel';
import { SubjectService } from '../../_services/SubjectService';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
 public subjects: SubjectModel[];
  constructor(public subjectService: SubjectService) {
    //debugger;
  }
  ngOnInit() {
    
    //debugger;
    let subjects = this.subjectService.getAllItems().subscribe(data => {
      this.subjects = data as SubjectModel[];
    });

  }
}
