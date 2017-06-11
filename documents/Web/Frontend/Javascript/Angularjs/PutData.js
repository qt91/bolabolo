/**
     * Update data
     *
     * @param url
     * @param data
     * @example this.putData('user/' + this.$stateParams.id,this.user);
     */
    putData(url, data){
        let $this = this;
        $this.API.all(url).customPUT(data).then(function(response){
            swal('Thành công!', 'C?p nh?t thành công!', 'success')
        }, function(response){
            var error = '';
            angular.forEach(response.data, function(value, key){
                error += key + ': ' + value + '\n';
            });
            swal('L?i', error, 'error')
        })
    }