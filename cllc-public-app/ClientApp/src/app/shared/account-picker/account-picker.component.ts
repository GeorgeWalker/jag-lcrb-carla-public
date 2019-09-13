import { Component, OnInit, ViewChild, Output, EventEmitter } from '@angular/core';
import { MatAutocompleteTrigger } from '@angular/material';
import { FormBuilder, FormGroup } from '@angular/forms';
import { AccountDataService } from '@services/account-data.service';
import { filter, tap, switchMap, map } from 'rxjs/operators';

@Component({
  selector: 'app-account-picker',
  templateUrl: './account-picker.component.html',
  styleUrls: ['./account-picker.component.scss']
})
export class AccountPickerComponent implements OnInit {
  @ViewChild('autocomplete', {read: MatAutocompleteTrigger}) inputAutoComplit: MatAutocompleteTrigger;
  @Output() valueSelected: EventEmitter<string> = new EventEmitter<string>();
  form: FormGroup;
  autocompleteAccounts: any[];
  constructor(private accountDataService: AccountDataService,
    private fb: FormBuilder) { }

  ngOnInit() {
    this.form = this.fb.group({
      autocompleteInput: ['']
    });

    this.form.get('autocompleteInput').valueChanges
      .pipe(filter(value => value && value.length >= 3),
        tap(_ => {
          this.autocompleteAccounts = [];
        }),
        switchMap(value => this.accountDataService.getAutocomplete(value)
          .pipe(map(data => {
            const list = [];
            // tslint:disable-next-line:forin
            for (const p in data) {
              list.push({ id: p, name: data[p] });
            }
            return list;
          }))
        ))
      .subscribe(data => {
        this.autocompleteAccounts = data;
        this.inputAutoComplit.openPanel();
      });
  }

  autocompleteDisplay(item: any) {
    return item.name;
  }

  onOptionSelect(event) {
    this.valueSelected.emit(event.value.id);
  }

}
