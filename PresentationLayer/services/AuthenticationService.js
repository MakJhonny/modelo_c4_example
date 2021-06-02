function getFlight() {
    return http.get(this.FlightUrl);
}
function updateFlight(num, Flight){
    let FlightSend = JSON.stringify(Flight);
    let httpOptions = {
        headers: new HttpHeaders({
        Authorization: `Bearer ${localStorage.getItem('jwt')}`,
        }),
    };
    return http.put(`${this.FlightUrl}/${num}`, Flight, httpOptions);
}