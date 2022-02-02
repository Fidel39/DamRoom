package com.example.DamRoom.domain;


import io.swagger.v3.oas.annotations.media.Schema;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import javax.validation.constraints.NotBlank;
import java.sql.Date;
import java.util.ArrayList;
import java.util.List;


@Data
@AllArgsConstructor
@Entity(name ="reservas")
public class Reservas {

    @Schema(description = "Identificador de la reserva", example = "1",
            required = true)
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int codReserva;

    @Schema(description = "Fecha de inicio de la reserva", example = "12/01/2022",
            required = true)
    @NotBlank
    @Column
    private Date fechaIni;


    @Schema(description = "Fecha de finalizacion de la reserva", example = "12/01/2022",
            required = true)
    @NotBlank
    @Column
    private Date fechaFin;

    @Schema(description = "Precio  de la reserva", example = "450€",
            required = true)
    @NotBlank
    @Column
    private Float importe;

    @Schema(description = "CheckIn de la reserva", example = "12/01/2022",
            required = true)
    @NotBlank
    @Column
    private Boolean checkIn;

    @Schema(description = "CheckOut de la reserva", example = "12/01/2022",
            required = true)
    @NotBlank
    @Column
    private Boolean checkOut;


    public Reservas(Date FechaIni, Date FechaFin, Float importe, Boolean checkIn, Boolean checkOut, Cliente cliente) {
        fechaIni = FechaIni;
        fechaFin = FechaFin;
        this.importe = importe;
        this.checkIn = checkIn;
        this.checkOut = checkOut;
        this.cliente = cliente;
    }

    @ManyToOne(fetch = FetchType.LAZY)
    private Cliente cliente;

    @OneToMany(mappedBy = "reserva", cascade = CascadeType.ALL)
    private List<Habitacion> habitaciones = new ArrayList<>();

    public int getCodReserva() {
        return codReserva;
    }

    public void setCodReserva(int codReserva) {
        this.codReserva = codReserva;
    }

    public Date getFechaIni() {
        return fechaIni;
    }

    public void setFechaIni(Date FechaIni) {
        this.fechaIni = FechaIni;
    }

    public Date getFechaFin() {
        return fechaFin;
    }

    public void setFechaFin(Date FechaFin) {
        this.fechaFin = FechaFin;
    }

    public Float getImporte() {
        return importe;
    }

    public void setImporte(Float importe) {
        this.importe = importe;
    }

    public Boolean getCheckIn() {
        return checkIn;
    }

    public void setCheckIn(Boolean checkIn) {
        checkIn = checkIn;
    }

    public Boolean getCheckOut() {
        return checkOut;
    }

    public void setCheckOut(Boolean checkOut) {
        checkOut = checkOut;
    }

    @Override
    public String toString() {
        return "Reservas{" +
                "codReserva=" + codReserva +
                ", FechaIni=" + fechaIni +
                ", FechaFin=" + fechaFin +
                ", importe=" + importe +
                ", CheckIn=" + checkIn +
                ", CheckOut=" + checkOut +
                ", cliente=" + cliente +
                '}';
    }
}
