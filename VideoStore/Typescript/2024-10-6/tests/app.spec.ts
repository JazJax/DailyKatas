import { VideoStore } from '@/app'

describe('VideoStore', () => {
  it('should exist', () => {
    expect(new VideoStore()).not.toBeNull
  });

  it('Should allow a user to rent a film', () => {
    let store = new VideoStore
    let customer = "Jasper"
    let result = store.rentVideo('The Martian', customer)
    expect(result).toBe(true)
  });

  it('Should not allow a user to rent a film that is already in use', () => {
    let store = new VideoStore
    let customer = "Jasper"
    let result1 = store.rentVideo('The Martian', customer)
    expect(result1).toBe(true)
    let result2 = store.rentVideo('The Martian', customer)
    expect(result2).toBe(false)
  });

  it('Should not allow a user to rent a second film', () => {
    let store = new VideoStore
    let customer = "Jasper"
    let result1 = store.rentVideo('The Martian', customer)
    expect(result1).toBe(true)
    let result2 = store.rentVideo('Doctor Whom', customer)
    expect(result2).toBe(false)
  });

  it('Should allow a second user to rent a second film', () => {
    let store = new VideoStore
    let customer1 = "Jasper"
    let customer2 = "Jackson"
    let result1 = store.rentVideo('The Martian', customer1)
    expect(result1).toBe(true)
    let result2 = store.rentVideo('Doctor Whom', customer2)
    expect(result2).toBe(true)
  });
});