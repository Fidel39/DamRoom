package com.example.DamRoom.service;

import com.example.DamRoom.domain.Reservas;
import com.example.DamRoom.exception.ReservaNotFoundException;
import com.example.DamRoom.repository.ReservaRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.Date;
import java.util.Set;
import java.util.Optional;

@Service
@Transactional
public class ReservaServiceImpl implements ReservaService{

    @Autowired
    private ReservaRepository reservaRepository;

    @Override
    public Set<Reservas> findAll() {
        return reservaRepository.findAll();
    }


    @Override
    public Set<Reservas> findByFechaIni(Date fechaIni){
        return reservaRepository.findByFechaIni(fechaIni);
    }

    @Override
    public Set<Reservas> findByFechaFin(Date fechaFin){
        return reservaRepository.findByFechaFin(fechaFin);
    }

    @Override
    public Set<Reservas> findByImporte(float importe){
        return reservaRepository.findByImporte(importe);
    }

    @Override
    public Set<Reservas> findByCheckIn(boolean checkIn){
        return reservaRepository.findByCheckIn(checkIn);
    }

    @Override
    public Set<Reservas> findByCheckOut(boolean checkOut){
        return reservaRepository.findByCheckOut(checkOut);
    }

    @Override
    public Optional<Reservas> findBycodReserva(int codReserva){
        return reservaRepository.findBycodReserva(codReserva);
    }

    @Override
    public Reservas addReserva(Reservas reservas){
        return reservaRepository.save(reservas);
    }

    @Override
    public Reservas modifyReserva(int codReserva, Reservas newReserva){
        Reservas reservas = reservaRepository.findBycodReserva(codReserva)
                .orElseThrow(() -> new ReservaNotFoundException(codReserva));
        newReserva.setCodReserva(reservas.getCodReserva());
        return reservaRepository.save(newReserva);
    }


    @Override
    public void deleteReserva(int codReserva){
        reservaRepository.findBycodReserva(codReserva)
                .orElseThrow(() -> new ReservaNotFoundException(codReserva));
        reservaRepository.deleteById(codReserva);
    }


}
