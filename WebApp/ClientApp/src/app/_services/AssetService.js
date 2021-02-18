"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
exports.SubjectService = void 0;
var core_1 = require("@angular/core");
var baseService_1 = require("./generic/baseService");
core_1.Injectable({ providedIn: 'root' });
var SubjectService = /** @class */ (function (_super) {
    __extends(SubjectService, _super);
    function SubjectService(http) {
        var _this = _super.call(this, http) || this;
        _this.baseUrl = "api/Subject";
        return _this;
    }
    return SubjectService;
}(baseService_1.BaseService));
exports.SubjectService = SubjectService;
//# sourceMappingURL=SubjectService.js.map